-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (token, rank, score) VALUES ('green', 93, 96.22);
INSERT INTO layout_items (token, rank, score) VALUES ('blue', 9, 37.85);
INSERT INTO layout_items (token, rank, score) VALUES ('edge', 57, 28.48);
