-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, owner, weight) VALUES ('fallback', 'staging', 48.62);
INSERT INTO layout_items (region, owner, weight) VALUES ('blue', 'blue', 71.05);
