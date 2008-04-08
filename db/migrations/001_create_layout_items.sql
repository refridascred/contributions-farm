-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    label TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (token, label, rank, count) VALUES ('blue', 'staging', 45, 54);
INSERT INTO layout_items (token, label, rank, count) VALUES ('stable', 'open', 50, 12);
INSERT INTO layout_items (token, label, rank, count) VALUES ('fallback', 'open', 83, 65);
