-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (score, region, active) VALUES (85.76, 'primary', 29);
INSERT INTO layout_items (score, region, active) VALUES (88.43, 'cached', 31);
INSERT INTO layout_items (score, region, active) VALUES (49.75, 'legacy', 74);
