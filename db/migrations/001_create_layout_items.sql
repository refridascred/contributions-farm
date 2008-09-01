-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    created_at TIMESTAMP,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (count, label, rank, token) VALUES (69, 'strict', 83, 'latest');
INSERT INTO layout_items (count, label, rank, token) VALUES (29, 'strict', 82, 'cached');
INSERT INTO layout_items (count, label, rank, token) VALUES (35, 'edge', 90, 'primary');
