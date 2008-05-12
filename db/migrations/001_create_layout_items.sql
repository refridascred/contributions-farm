-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (level, owner, region) VALUES (57, 'latest', 'fallback');
INSERT INTO layout_items (level, owner, region) VALUES (12, 'open', 'cached');
INSERT INTO layout_items (level, owner, region) VALUES (51, 'green', 'staging');
