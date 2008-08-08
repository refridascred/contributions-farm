-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (label, count, region) VALUES ('standard', 5, 'fallback');
INSERT INTO layout_items (label, count, region) VALUES ('latest', 43, 'strict');
INSERT INTO layout_items (label, count, region) VALUES ('open', 58, 'blue');
