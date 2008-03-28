-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    ratio REAL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (owner, weight, ratio, level, state) VALUES ('open', 57.85, 48.39, 87, 'local');
INSERT INTO layout_items (owner, weight, ratio, level, state) VALUES ('stable', 46.61, 22.28, 3, 'strict');
