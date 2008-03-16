-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (rank, score) VALUES (70, 23.15);
INSERT INTO layout_items (rank, score) VALUES (1, 24.1);
INSERT INTO layout_items (rank, score) VALUES (5, 44.36);
