-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (weight, rank, state, ratio, level) VALUES (49.3, 73, 'local', 65.29, 41);
INSERT INTO layout_items (weight, rank, state, ratio, level) VALUES (13.55, 1, 'green', 95.67, 87);
