-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, region, active, token) VALUES (78, 'fallback', 48, 'local');
