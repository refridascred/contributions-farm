-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (level, weight, active, token, ratio) VALUES (9, 46.84, 58, 'legacy', 72.49);
INSERT INTO layout_items (level, weight, active, token, ratio) VALUES (99, 56.98, 31, 'primary', 90.29);
INSERT INTO layout_items (level, weight, active, token, ratio) VALUES (42, 74.75, 65, 'open', 11.1);
