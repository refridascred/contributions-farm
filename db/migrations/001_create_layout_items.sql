-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (weight, owner, state) VALUES (68.68, 'eu-west', 'standard');
INSERT INTO layout_items (weight, owner, state) VALUES (14.01, 'strict', 'eu-west');
