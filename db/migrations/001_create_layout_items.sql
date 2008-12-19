-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, owner, weight, label) VALUES ('staging', 'eu-west', 92.53, 'open');
INSERT INTO layout_items (state, owner, weight, label) VALUES ('open', 'cached', 75.72, 'edge');
