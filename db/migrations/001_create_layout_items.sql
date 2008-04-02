-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (count, token, region) VALUES (57, 'staging', 'legacy');
INSERT INTO layout_items (count, token, region) VALUES (66, 'edge', 'fallback');
INSERT INTO layout_items (count, token, region) VALUES (0, 'blue', 'green');
