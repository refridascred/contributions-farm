-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (label, region, token) VALUES ('blue', 'eu-west', 'fallback');
INSERT INTO layout_items (label, region, token) VALUES ('legacy', 'fallback', 'green');
INSERT INTO layout_items (label, region, token) VALUES ('green', 'open', 'staging');
