-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (level, label, ratio, rank) VALUES (69, 'cached', 69.48, 42);
INSERT INTO layout_items (level, label, ratio, rank) VALUES (76, 'fallback', 69.55, 71);
