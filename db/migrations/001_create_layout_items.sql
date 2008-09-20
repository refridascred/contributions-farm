-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (ratio, label, token) VALUES (71.44, 'edge', 'staging');
INSERT INTO layout_items (ratio, label, token) VALUES (37.74, 'latest', 'eu-west');
