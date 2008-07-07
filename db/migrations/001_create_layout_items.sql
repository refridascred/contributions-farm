-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (state, rank, token, score) VALUES ('blue', 40, 'blue', 1.24);
INSERT INTO layout_items (state, rank, token, score) VALUES ('edge', 52, 'primary', 29.06);
INSERT INTO layout_items (state, rank, token, score) VALUES ('staging', 82, 'strict', 61.65);
