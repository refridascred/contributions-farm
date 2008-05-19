-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (label, ratio, owner, count, region) VALUES ('strict', 57.66, 'fallback', 72, 'legacy');
INSERT INTO layout_items (label, ratio, owner, count, region) VALUES ('strict', 86.76, 'green', 70, 'strict');
