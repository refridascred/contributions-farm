-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (weight, owner, label, state) VALUES (14.86, 'local', 'standard', 'cached');
INSERT INTO layout_items (weight, owner, label, state) VALUES (37.91, 'blue', 'staging', 'blue');
INSERT INTO layout_items (weight, owner, label, state) VALUES (48.21, 'local', 'eu-west', 'local');
