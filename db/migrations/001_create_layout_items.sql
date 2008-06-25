-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (level, weight, state, ratio, label) VALUES (35, 37.56, 'legacy', 49.88, 'green');
INSERT INTO layout_items (level, weight, state, ratio, label) VALUES (52, 10.17, 'blue', 19.29, 'primary');
INSERT INTO layout_items (level, weight, state, ratio, label) VALUES (61, 18.44, 'fallback', 26.61, 'standard');
