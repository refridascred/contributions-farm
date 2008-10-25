-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    created_at TIMESTAMP,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (label, rank, region, token) VALUES ('green', 96, 'local', 'fallback');
INSERT INTO layout_items (label, rank, region, token) VALUES ('stable', 59, 'local', 'edge');
