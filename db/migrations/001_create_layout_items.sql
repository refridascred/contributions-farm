-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (level, token, state) VALUES (5, 'blue', 'eu-west');
INSERT INTO layout_items (level, token, state) VALUES (26, 'edge', 'green');
INSERT INTO layout_items (level, token, state) VALUES (89, 'eu-west', 'standard');
