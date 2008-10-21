-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, state, count, level, ratio) VALUES ('edge', 'stable', 38, 85, 71.63);
INSERT INTO layout_items (region, state, count, level, ratio) VALUES ('primary', 'latest', 25, 72, 11.06);
INSERT INTO layout_items (region, state, count, level, ratio) VALUES ('stable', 'eu-west', 37, 89, 86.92);
