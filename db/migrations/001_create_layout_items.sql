-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, count, rank, score) VALUES ('legacy', 22, 14, 45.45);
INSERT INTO layout_items (state, count, rank, score) VALUES ('latest', 80, 53, 48.23);
