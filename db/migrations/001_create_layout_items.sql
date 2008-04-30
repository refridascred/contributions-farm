-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (state, ratio, active, weight) VALUES ('standard', 85.86, 35, 78.93);
INSERT INTO layout_items (state, ratio, active, weight) VALUES ('stable', 25.15, 94, 24.91);
INSERT INTO layout_items (state, ratio, active, weight) VALUES ('edge', 29.14, 20, 73.56);
