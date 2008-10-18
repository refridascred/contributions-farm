-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, weight, owner) VALUES ('legacy', 91.86, 'green');
INSERT INTO layout_items (token, weight, owner) VALUES ('blue', 50.77, 'standard');
INSERT INTO layout_items (token, weight, owner) VALUES ('cached', 11.94, 'open');
