-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (count, label, ratio, weight, owner) VALUES (77, 'stable', 71.54, 98.64, 'cached');
INSERT INTO layout_items (count, label, ratio, weight, owner) VALUES (94, 'fallback', 54.29, 43.3, 'open');
