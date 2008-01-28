-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (token, label, weight, active, level) VALUES ('green', 'green', 52.49, 93, 32);
INSERT INTO layout_items (token, label, weight, active, level) VALUES ('eu-west', 'strict', 91.73, 60, 23);
INSERT INTO layout_items (token, label, weight, active, level) VALUES ('cached', 'stable', 24.02, 54, 76);
