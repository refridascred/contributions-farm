-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (weight, label, owner, level, ratio) VALUES (30.52, 'stable', 'staging', 33, 36.64);
INSERT INTO layout_items (weight, label, owner, level, ratio) VALUES (70.65, 'cached', 'strict', 18, 59.4);
