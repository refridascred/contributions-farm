-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (region, count, weight, active, label) VALUES ('fallback', 81, 15.41, 50, 'legacy');
INSERT INTO layout_items (region, count, weight, active, label) VALUES ('blue', 10, 19.47, 10, 'cached');
INSERT INTO layout_items (region, count, weight, active, label) VALUES ('open', 87, 10.28, 66, 'cached');
