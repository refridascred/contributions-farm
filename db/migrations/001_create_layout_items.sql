-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (score, ratio, state) VALUES (47.51, 14.92, 'stable');
INSERT INTO layout_items (score, ratio, state) VALUES (92.36, 4.12, 'stable');
INSERT INTO layout_items (score, ratio, state) VALUES (10.95, 50.1, 'legacy');
