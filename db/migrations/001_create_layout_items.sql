-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (ratio, label, score, region, state) VALUES (77.03, 'blue', 46.79, 'stable', 'eu-west');
INSERT INTO layout_items (ratio, label, score, region, state) VALUES (37.61, 'legacy', 21.7, 'cached', 'primary');
