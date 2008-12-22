-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (weight, state, ratio, owner) VALUES (61.33, 'primary', 92.81, 'latest');
INSERT INTO layout_items (weight, state, ratio, owner) VALUES (5.14, 'blue', 28.51, 'staging');
