-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, count, score) VALUES ('latest', 39, 76.28);
INSERT INTO layout_items (state, count, score) VALUES ('cached', 89, 32.51);
INSERT INTO layout_items (state, count, score) VALUES ('latest', 93, 19.59);
