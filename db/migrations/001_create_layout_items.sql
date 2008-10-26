-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (owner, weight, state, count, label) VALUES ('standard', 7.96, 'fallback', 34, 'blue');
INSERT INTO layout_items (owner, weight, state, count, label) VALUES ('fallback', 64.26, 'strict', 85, 'green');
INSERT INTO layout_items (owner, weight, state, count, label) VALUES ('cached', 2.08, 'eu-west', 86, 'staging');
