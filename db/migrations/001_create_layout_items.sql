-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (ratio, label, region) VALUES (86.91, 'primary', 'cached');
INSERT INTO layout_items (ratio, label, region) VALUES (46.92, 'legacy', 'eu-west');
INSERT INTO layout_items (ratio, label, region) VALUES (44.06, 'staging', 'open');
