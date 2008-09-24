-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (level, region, count, active, label) VALUES (87, 'open', 27, 25, 'green');
INSERT INTO layout_items (level, region, count, active, label) VALUES (90, 'cached', 1, 36, 'staging');
INSERT INTO layout_items (level, region, count, active, label) VALUES (98, 'latest', 34, 52, 'blue');
