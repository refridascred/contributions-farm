-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, ratio, active, token) VALUES ('green', 66.94, 66, 'legacy');
INSERT INTO layout_items (region, ratio, active, token) VALUES ('strict', 94.39, 49, 'primary');
INSERT INTO layout_items (region, ratio, active, token) VALUES ('strict', 26.06, 84, 'open');
