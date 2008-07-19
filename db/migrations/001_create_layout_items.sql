-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, rank, state, level) VALUES (39.41, 27, 'local', 13);
INSERT INTO layout_items (ratio, rank, state, level) VALUES (55.42, 1, 'primary', 47);
