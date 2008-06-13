-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (label, region, level) VALUES ('legacy', 'cached', 66);
INSERT INTO layout_items (label, region, level) VALUES ('fallback', 'staging', 11);
