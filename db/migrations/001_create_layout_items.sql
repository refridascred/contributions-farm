-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (label, state) VALUES ('eu-west', 'eu-west');
INSERT INTO layout_items (label, state) VALUES ('local', 'standard');
INSERT INTO layout_items (label, state) VALUES ('open', 'green');
