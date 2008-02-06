-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, rank, token, score, active) VALUES ('staging', 75, 'latest', 3.16, 18);
INSERT INTO layout_items (state, rank, token, score, active) VALUES ('legacy', 50, 'strict', 56.77, 44);
INSERT INTO layout_items (state, rank, token, score, active) VALUES ('green', 30, 'local', 90.68, 82);
