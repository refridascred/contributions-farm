-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (token, ratio, region) VALUES ('strict', 11.0, 'staging');
INSERT INTO layout_items (token, ratio, region) VALUES ('local', 25.67, 'primary');
