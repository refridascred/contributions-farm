-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    rank INTEGER,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (token, region, rank, label) VALUES ('green', 'staging', 56, 'strict');
INSERT INTO layout_items (token, region, rank, label) VALUES ('fallback', 'latest', 5, 'green');
