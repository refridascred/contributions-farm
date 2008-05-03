-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    rank INTEGER,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, weight, rank, level, state) VALUES (39.76, 10.2, 62, 38, 'stable');
INSERT INTO layout_items (ratio, weight, rank, level, state) VALUES (11.31, 98.57, 60, 10, 'latest');
INSERT INTO layout_items (ratio, weight, rank, level, state) VALUES (79.77, 0.65, 79, 24, 'legacy');
