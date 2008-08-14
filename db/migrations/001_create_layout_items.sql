-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, owner, weight) VALUES (39, 'edge', 33.73);
INSERT INTO layout_items (level, owner, weight) VALUES (17, 'green', 81.64);
INSERT INTO layout_items (level, owner, weight) VALUES (21, 'stable', 96.32);
