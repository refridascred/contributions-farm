-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    region TEXT,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (token, region, label, level) VALUES ('strict', 'latest', 'green', 54);
INSERT INTO layout_items (token, region, label, level) VALUES ('eu-west', 'staging', 'local', 78);
INSERT INTO layout_items (token, region, label, level) VALUES ('strict', 'fallback', 'green', 95);
