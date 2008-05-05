-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (level, label, state, weight, owner) VALUES (5, 'staging', 'eu-west', 73.1, 'cached');
INSERT INTO layout_items (level, label, state, weight, owner) VALUES (51, 'standard', 'cached', 83.15, 'open');
INSERT INTO layout_items (level, label, state, weight, owner) VALUES (94, 'primary', 'primary', 84.06, 'blue');
