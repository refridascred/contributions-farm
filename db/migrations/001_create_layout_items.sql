-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, region, count, owner) VALUES ('local', 'fallback', 92, 'stable');
INSERT INTO layout_items (label, region, count, owner) VALUES ('green', 'open', 41, 'green');
INSERT INTO layout_items (label, region, count, owner) VALUES ('stable', 'legacy', 40, 'strict');
