-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    label TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (owner, weight, label, level, ratio) VALUES ('stable', 93.46, 'strict', 61, 77.94);
INSERT INTO layout_items (owner, weight, label, level, ratio) VALUES ('edge', 3.48, 'eu-west', 12, 77.76);
INSERT INTO layout_items (owner, weight, label, level, ratio) VALUES ('local', 98.8, 'open', 62, 50.61);
