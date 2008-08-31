-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (weight, state, level, owner, token) VALUES (15.26, 'latest', 30, 'primary', 'green');
INSERT INTO layout_items (weight, state, level, owner, token) VALUES (47.46, 'staging', 58, 'latest', 'green');
INSERT INTO layout_items (weight, state, level, owner, token) VALUES (48.81, 'cached', 71, 'eu-west', 'standard');
