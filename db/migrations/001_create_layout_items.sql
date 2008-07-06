-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (active, count, region) VALUES (48, 72, 'eu-west');
INSERT INTO layout_items (active, count, region) VALUES (44, 11, 'edge');
INSERT INTO layout_items (active, count, region) VALUES (10, 87, 'staging');
