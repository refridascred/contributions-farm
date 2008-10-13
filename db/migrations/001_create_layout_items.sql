-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (weight, owner, state, ratio) VALUES (36.54, 'latest', 'green', 22.96);
INSERT INTO layout_items (weight, owner, state, ratio) VALUES (35.07, 'local', 'stable', 97.39);
