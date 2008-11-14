-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    level INTEGER,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (region, label, level, ratio) VALUES ('cached', 'standard', 86, 12.46);
INSERT INTO layout_items (region, label, level, ratio) VALUES ('blue', 'stable', 33, 62.28);
INSERT INTO layout_items (region, label, level, ratio) VALUES ('staging', 'green', 38, 60.74);
