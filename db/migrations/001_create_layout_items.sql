-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (weight, owner, token) VALUES (95.17, 'cached', 'open');
INSERT INTO layout_items (weight, owner, token) VALUES (53.25, 'primary', 'standard');
INSERT INTO layout_items (weight, owner, token) VALUES (63.37, 'open', 'latest');
