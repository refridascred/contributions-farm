-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (rank, score) VALUES (13, 50.47);
INSERT INTO layout_items (rank, score) VALUES (63, 84.24);
INSERT INTO layout_items (rank, score) VALUES (55, 74.02);
