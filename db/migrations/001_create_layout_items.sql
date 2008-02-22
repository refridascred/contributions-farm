-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (token, region, weight) VALUES ('fallback', 'edge', 52.39);
INSERT INTO layout_items (token, region, weight) VALUES ('legacy', 'staging', 17.07);
