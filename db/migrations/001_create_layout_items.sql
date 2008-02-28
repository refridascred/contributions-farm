-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (state, owner, weight, token) VALUES ('blue', 'staging', 65.06, 'staging');
INSERT INTO layout_items (state, owner, weight, token) VALUES ('strict', 'strict', 6.39, 'blue');
