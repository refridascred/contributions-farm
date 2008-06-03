-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (weight, state, level, ratio, rank) VALUES (68.56, 'green', 88, 49.17, 90);
INSERT INTO layout_items (weight, state, level, ratio, rank) VALUES (2.41, 'eu-west', 66, 71.29, 28);
INSERT INTO layout_items (weight, state, level, ratio, rank) VALUES (42.74, 'standard', 31, 84.37, 74);
