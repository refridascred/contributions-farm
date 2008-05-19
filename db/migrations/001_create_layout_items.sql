-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (level, weight, label, active, ratio) VALUES (97, 19.84, 'eu-west', 24, 37.63);
INSERT INTO layout_items (level, weight, label, active, ratio) VALUES (19, 46.19, 'blue', 89, 19.2);
