-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, state, weight) VALUES ('strict', 'open', 24.57);
INSERT INTO layout_items (owner, state, weight) VALUES ('stable', 'blue', 96.46);
INSERT INTO layout_items (owner, state, weight) VALUES ('green', 'blue', 77.09);
