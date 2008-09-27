-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    weight REAL,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, token, weight, region, label) VALUES (57, 'staging', 52.61, 'staging', 'staging');
INSERT INTO layout_items (active, token, weight, region, label) VALUES (57, 'staging', 70.72, 'edge', 'eu-west');
INSERT INTO layout_items (active, token, weight, region, label) VALUES (72, 'edge', 72.87, 'stable', 'open');
